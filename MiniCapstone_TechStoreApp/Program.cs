using MiniCapstone_TechStoreApp.DatabaseMongoDB;
using MiniCapstone_TechStoreApp.Services;
using MiniCapstone_TechStoreApp.FormsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                MongoDBConnector db = new MongoDBConnector();

                // Create indexes before showing the application.
                //db.CreateIndexesAsync().GetAwaiter().GetResult();

                EmailService emailService = new EmailService();

                EmailVerificationService verificationService = new EmailVerificationService(db, emailService);

                AuthenticatorService authService = new AuthenticatorService(db, verificationService);

                //Application.Run(new RegistrationForm(authService));

                //Test Form UI
                //Application.Run(new VerifyEmailForm(authService, "a", "b", "c"));
                //Application.Run(new LoginForm(authService));
                Application.Run(new AdminDashboardForm("admin", "12345678", true, db));
                //Application.Run(new AdminDashboardContent());
                //Application.Run(new UserDashboardForm());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
