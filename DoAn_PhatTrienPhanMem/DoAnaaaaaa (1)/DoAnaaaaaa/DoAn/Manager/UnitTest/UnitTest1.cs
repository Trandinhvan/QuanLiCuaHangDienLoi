using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int ma;
            double? tongtien;
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                HOADON hd = new HOADON();
                hd.MANV = "0127234980";
                hd.MAKH = "0933392322";
                hd.NGAYBAN = DateTime.Now;
                db.HOADONs.InsertOnSubmit(hd);
                db.SubmitChanges();
                CHITIETHD ct = new CHITIETHD();
                ct.MAHD = hd.MAHD;
                ct.MAHG = 100000;
                ct.SOLUONG = 101;
                ct.DONGIA = 50000;
                db.CHITIETHDs.InsertOnSubmit(ct);
                db.SubmitChanges();
                ma = hd.MAHD;
                tongtien = ct.DONGIA * ct.SOLUONG*1.0;
            }
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                Assert.AreEqual(db.HOADONs.Where(t => t.MAHD == ma).FirstOrDefault().TAMTINH, tongtien);
            }
        }
    }
}
