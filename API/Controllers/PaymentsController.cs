using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PaymentsController : BaseApiController
    {
        private readonly PaymentService _paymentService;
        private readonly StoreContext _context;

        public PaymentsController(PaymentService paymentService, StoreContext context)
        {
            _paymentService = paymentService;
            _context = context;
        }
    }
}