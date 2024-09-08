using System;
using ClinicManagmentAPI_Repos.DTOs.Invoice;using ClinicManagmentAPI_Repos.Models.Entities;namespace ClinicManagmentAPI_Repos.Interface
{
	public interface IInvoiceService
	{
		Task<List<InvoiceDTO>>GetAllInvoice( );
		Task CreateInvoice(InvoiceCreateDTO dto);		Task UpdatesInvoice(InvoiceUpdateDTO dto);		Task DeleteInvoice(int id);        Task<Invoice> GetInvoice(int id);    }
}

