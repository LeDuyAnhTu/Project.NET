using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DTOUnitTest
{
    [TestClass]
    public class CaLamTests
    {
        [TestMethod]
        public void TestMaCa()
        {
            var obj = new DTO.CaLam_DTO("Ca123456", "Ca Sáng", "08:00", "12:00");

            // Kiểm tra xem việc gán một giá trị hợp lệ cho MaCa có gây ra ngoại lệ không
            Assert.ThrowsException<Exception>(() => obj.MaCa = "Ca12345678901");

            // Kiểm tra xem việc gán null cho MaCa có gây ra ngoại lệ như mong đợi không
            Assert.ThrowsException<Exception>(() => obj.MaCa = null);

            // Kiểm tra xem việc gán một giá trị hợp lệ cho MaCa có gây ra ngoại lệ không
            Assert.ThrowsException<Exception>(() => obj.MaCa = null);
        }
    }
}
