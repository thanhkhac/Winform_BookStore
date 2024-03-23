using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using MiniProject_BookStore.DataAccess;
using MiniProject_BookStore.Models;

namespace MiniProject_BookStore
{
    public partial class PrintInvoice : Form
    {
        BookStoreContext db = DbContextSingleton.Instance;

        public Invoice invoice { get; set; }         
        public PrintInvoice()
        {
            InitializeComponent();
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportPath = "F:\\Doc_FPT\\SEM_5\\PRN211\\Code\\MiniProject_BookStore\\MiniProject_BookStore\\Invoice.rdlc";

            var invoiceDetails = db.InvoiceDetails.Where(x=> x.Id == invoice.Id).ToList();

            List<InvoiceDataSet> invoices = new List<InvoiceDataSet>();
            decimal totalPrice = 0;
            foreach ( var invoiceDetail in invoiceDetails )
            {
                InvoiceDataSet invoiceDataSet = new InvoiceDataSet
                {
                    ID = invoiceDetail.Book.Id.ToString(),
                    Name = invoiceDetail.Book.Name,
                    Price = invoiceDetail.Book.Price.ToString(),
                    Quantity = invoiceDetail.Quantity.ToString(),
                    Total = (invoiceDetail.Book.Price * invoiceDetail.Quantity).ToString()
                };
                invoices.Add(invoiceDataSet);
                totalPrice += ((decimal)invoiceDetail.Book.Price * (decimal)invoiceDetail.Quantity);
            }


var reportDataSource = new ReportDataSource("dataset", invoices);

reportViewer1.LocalReport.SetParameters(new ReportParameter("Date", invoice.CreatedDate.ToString()));
reportViewer1.LocalReport.SetParameters(new ReportParameter("InvoiceID", invoice.Id.ToString()));
reportViewer1.LocalReport.SetParameters(new ReportParameter("TotalPrice", totalPrice.ToString()));
reportViewer1.LocalReport.SetParameters(new ReportParameter("CustomerName", invoice.CustomerName));
reportViewer1.LocalReport.SetParameters(new ReportParameter("CustomerPhone", invoice.CustomerPhone));
            
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }

    }
}