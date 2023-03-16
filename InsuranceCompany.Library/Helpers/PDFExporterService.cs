using Aspose.Pdf;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Forms;
using InsuranceCompany.Library.Core.Model;
using InsuranceCompany.Library.Core.Repository.Core;
using InsuranceCompany.Library.Helpers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace InsuranceCompany.Library.Helpers
{
    public class PDFExporterService : IPDFExporterService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public PDFExporterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private TextBoxField CreateField(Aspose.Pdf.Document document, string value, int i, int j)
        {
            TextBoxField field = new TextBoxField(document.Pages[1], new Aspose.Pdf.Rectangle(25 + i, 825 - j, 750 - j, 750 - j));
            field.Value = value;
            field.DefaultAppearance.FontSize = 15;
            field.ReadOnly = true;
            Border border = new Border(field);
            border.Width = 5;
            border.Dash = new Dash(1, 1);
            return field;
        }

        public FileContentResult GeneratePolicyPDF(int id)
        {
            var document = new Aspose.Pdf.Document
            {
                PageInfo = new PageInfo { Margin = new MarginInfo(28, 28, 28, 40)}
            };
            var pdfPage = document.Pages.Add();
            SignedPolicy policy = _unitOfWork.PolicyRepository.FindById(id);

            TextBoxField field = CreateField(document, "Automobil: ", 0, 0);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.Car.RegisterNumber + ", " + policy.Car.Brand + " " + policy.Car.Model, 100, 0);
            document.Form.Add(field, 1);
            field = CreateField(document, "Vlasnik: ", 0, 30);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.Car.Owner.FirstName + " " + policy.Car.Owner.LastName + ", JMBG: " + policy.Car.Owner.UniqueMasterCitizenNumber, 100, 30);
            document.Form.Add(field, 1);
            field = CreateField(document, "Paket pomoci: ", 0, 60);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.AidPackage.Description, 100, 60);
            document.Form.Add(field, 1);
            field = CreateField(document, "Cena: ", 0, 90);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.AidPackage.Price.ToString(), 100, 90);
            document.Form.Add(field, 1);
            field = CreateField(document, "Pokrice: ", 0, 120);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.AidPackage.Cover.ToString(), 100, 120);
            document.Form.Add(field, 1);
            field = CreateField(document, "Trajanje: ", 0, 150);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.AidPackage.DurationInMonths.ToString() + " meseci", 100, 150);
            document.Form.Add(field, 1);

            field = CreateField(document, "Datum: ", 110, 250);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.Date.Day.ToString() + "/" + policy.Date.Month.ToString() + "/" + policy.Date.Year.ToString(), 160, 250);
            document.Form.Add(field, 1);
            field = CreateField(document, "Agent: ", 110, 280);
            document.Form.Add(field, 1);
            field = CreateField(document, policy.Agent.FirstName + " " + policy.Agent.LastName + ", Br Licence: " + policy.Agent.LicenceNumber, 160, 280);
            document.Form.Add(field, 1);


            using (var streamout = new MemoryStream())
            {
                document.Save(streamout);
                return new FileContentResult(streamout.ToArray(), "application/pdf")
                {
                    FileDownloadName = "Polisa"
                };
            }
        }
    }
}
