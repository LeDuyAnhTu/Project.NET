using DAL;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DTOUnitTest
{
    [TestClass]
    public class ThongKeKhuyenMaiTests
    {
        private ThongKeKhuyenMai_DAL thongKeKhuyenMai_DAL; 

        [TestInitialize]
        public void Setup()
        {
            thongKeKhuyenMai_DAL = new ThongKeKhuyenMai_DAL(); 
        }

        [TestMethod]
        public void TestSoLuongConLaiSauKhiMuaHang()
        {
            // Giả sử mã sản phẩm và số lượng mua
            string maSP = "SP00000001";
            int soLuongMua = 10;

            // Lấy số lượng còn lại trước khi mua hàng
            int soLuongConLaiTruoc = thongKeKhuyenMai_DAL.LaySoLuongConLai(maSP);

            // Thực hiện giao dịch mua hàng
            thongKeKhuyenMai_DAL.MuaHang(maSP, soLuongMua);

            // Lấy số lượng còn lại sau khi mua hàng
            int soLuongConLaiSau = thongKeKhuyenMai_DAL.LaySoLuongConLai(maSP);

            // Kiểm tra xem số lượng còn lại có được cập nhật chính xác hay không
            Assert.AreEqual(soLuongConLaiTruoc - soLuongMua, soLuongConLaiSau);
        }
    }
}
