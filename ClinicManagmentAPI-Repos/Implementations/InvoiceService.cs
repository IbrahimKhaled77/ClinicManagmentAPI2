using ClinicManagementAPI.Context;
using ClinicManagmentAPI_Repos.DTOs.Invoice;
using ClinicManagmentAPI_Repos.Interface;
using ClinicManagmentAPI_Repos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagmentAPI_Repos.Implementations
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ClinicManagementDbContext _context;
        public InvoiceService(ClinicManagementDbContext context)
        {
            _context = context;
        }
        public Task CreateInvoice(InvoiceCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInvoice(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InvoiceDTO>> GetAllInvoice()
        {
            throw new NotImplementedException();
        }

        public Task<Invoice> GetInvoice(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatesInvoice(InvoiceUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
