using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public class WaitFormManager
    {
        private Stopwatch stopwatch;
        private Form parentForm;

        public WaitFormManager(Form parentForm)
        {
            this.parentForm = parentForm;
            this.stopwatch = new Stopwatch();
        }

        public async Task ShowWaitForm(Func<Task> action)
        {
            // Hiển thị WaitForm bên trong MainForm
            SplashScreenManager.ShowForm(this.parentForm, typeof(frmWaiting), true, true, SplashFormStartPosition.CenterScreen, new Point());

            // Bắt đầu đếm thời gian
            this.stopwatch.Start();

            // Thực hiện các tác vụ tải dữ liệu một cách bất đồng bộ
            await action();

            // Dừng đếm thời gian
            this.stopwatch.Stop();

            // Lấy thời gian đã trôi qua từ lúc bắt đầu đến khi dừng, tính bằng giây
            double seconds = this.stopwatch.Elapsed.TotalSeconds;

            // Tạo một khoảng trễ bằng số giây mà tác vụ mất
            await Task.Delay(TimeSpan.FromSeconds(seconds));

            // Đóng WaitForm khi hoàn thành
            SplashScreenManager.CloseForm();

            // Hiển thị thời gian thực hiện
            //MessageBox.Show("Thời gian thực hiện: " + seconds.ToString() + " giây");
        }
    }
}
