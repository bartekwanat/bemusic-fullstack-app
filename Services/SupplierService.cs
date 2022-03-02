using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using bemusic.Entities;
using bemusic.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace bemusic.Services
{
    public interface ISupplierService
    {
        string AddSupplier(CreateSupplierDto dto);
    }

    public class SupplierService : ISupplierService
    {
        private readonly BeMusicDbContext _context;
        private readonly IMapper _mapper;

        public SupplierService(BeMusicDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public string AddSupplier(CreateSupplierDto dto)
        {
            var supplier = _mapper.Map<Supplier>(dto);
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();

            return supplier.Name;
        }
    }
}