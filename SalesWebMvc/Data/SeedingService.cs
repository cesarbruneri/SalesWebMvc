using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;//DB has beem seeded
            }
            DepartmentModel d1 = new DepartmentModel("Computer");
            DepartmentModel d2 = new DepartmentModel("Eletronics");
            DepartmentModel d3 = new DepartmentModel("Fashion");
            DepartmentModel d4 = new DepartmentModel("Books");

            SellerModel s1 = new SellerModel("Bob Brown", "bob@gmail.com", new DateTime(1998,4,21),1000.0,d1);
            SellerModel s2 = new SellerModel("Maria Green", "maria@gmail.com", new DateTime(1978, 12, 31), 3500.0, d2);
            SellerModel s3 = new SellerModel("Alex Gray", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            SellerModel s4 = new SellerModel("Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            SellerModel s5 = new SellerModel("Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            SellerModel s6 = new SellerModel("Alex Pink", "alexp@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecordModel r1 = new SalesRecordModel(new DateTime(2018, 09, 25), 11000.0, SaleStatusEnum.Billed, s1);
            SalesRecordModel r2 = new SalesRecordModel(new DateTime(2018, 09, 4), 7000.0, SaleStatusEnum.Billed, s5);
            SalesRecordModel r3 = new SalesRecordModel(new DateTime(2018, 09, 13), 4000.0, SaleStatusEnum.Canceled, s4);
            SalesRecordModel r4 = new SalesRecordModel(new DateTime(2018, 09, 1), 8000.0, SaleStatusEnum.Billed, s1);
            SalesRecordModel r5 = new SalesRecordModel(new DateTime(2018, 09, 21), 3000.0, SaleStatusEnum.Billed, s3);
            SalesRecordModel r6 = new SalesRecordModel(new DateTime(2018, 09, 15), 2000.0, SaleStatusEnum.Billed, s1);
            SalesRecordModel r7 = new SalesRecordModel(new DateTime(2018, 09, 28), 13000.0, SaleStatusEnum.Billed, s2);
            SalesRecordModel r8 = new SalesRecordModel(new DateTime(2018, 09, 11), 4000.0, SaleStatusEnum.Billed, s4);
            SalesRecordModel r9 = new SalesRecordModel(new DateTime(2018, 09, 14), 11000.0, SaleStatusEnum.Pending, s6);
            SalesRecordModel r10 = new SalesRecordModel(new DateTime(2018, 09, 7), 9000.0, SaleStatusEnum.Billed, s6);
            SalesRecordModel r11 = new SalesRecordModel(new DateTime(2018, 09, 13), 6000.0, SaleStatusEnum.Billed, s2);
            SalesRecordModel r12 = new SalesRecordModel(new DateTime(2018, 09, 25), 7000.0, SaleStatusEnum.Pending, s3);
            SalesRecordModel r13 = new SalesRecordModel(new DateTime(2018, 09, 29), 10000.0, SaleStatusEnum.Billed, s4);
            SalesRecordModel r14 = new SalesRecordModel(new DateTime(2018, 09, 4), 3000.0, SaleStatusEnum.Billed, s5);
            SalesRecordModel r15 = new SalesRecordModel(new DateTime(2018, 09, 12), 4000.0, SaleStatusEnum.Billed, s1);
            SalesRecordModel r16 = new SalesRecordModel(new DateTime(2018, 10, 5), 2000.0, SaleStatusEnum.Billed, s4);
            SalesRecordModel r17 = new SalesRecordModel(new DateTime(2018, 10, 1), 12000.0, SaleStatusEnum.Billed, s1);
            SalesRecordModel r18 = new SalesRecordModel(new DateTime(2018, 10, 24), 6000.0, SaleStatusEnum.Billed, s3);
            SalesRecordModel r19 = new SalesRecordModel(new DateTime(2018, 10, 22), 8000.0, SaleStatusEnum.Billed, s5);
            SalesRecordModel r20 = new SalesRecordModel(new DateTime(2018, 10, 15), 8000.0, SaleStatusEnum.Billed, s6);
            SalesRecordModel r21 = new SalesRecordModel(new DateTime(2018, 10, 17), 9000.0, SaleStatusEnum.Billed, s2);
            SalesRecordModel r22 = new SalesRecordModel(new DateTime(2018, 10, 24), 4000.0, SaleStatusEnum.Billed, s4);
            SalesRecordModel r23 = new SalesRecordModel(new DateTime(2018, 10, 19), 11000.0, SaleStatusEnum.Canceled, s2);
            SalesRecordModel r24 = new SalesRecordModel(new DateTime(2018, 10, 12), 8000.0, SaleStatusEnum.Billed, s5);
            SalesRecordModel r25 = new SalesRecordModel(new DateTime(2018, 10, 31), 7000.0, SaleStatusEnum.Billed, s3);
            SalesRecordModel r26 = new SalesRecordModel(new DateTime(2018, 10, 6), 5000.0, SaleStatusEnum.Billed, s4);
            SalesRecordModel r27 = new SalesRecordModel(new DateTime(2018, 10, 13), 9000.0, SaleStatusEnum.Pending, s1);
            SalesRecordModel r28 = new SalesRecordModel(new DateTime(2018, 10, 7), 4000.0, SaleStatusEnum.Billed, s3);
            SalesRecordModel r29 = new SalesRecordModel(new DateTime(2018, 10, 23), 12000.0, SaleStatusEnum.Billed, s5);
            SalesRecordModel r30 = new SalesRecordModel(new DateTime(2018, 10, 12), 5000.0, SaleStatusEnum.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
