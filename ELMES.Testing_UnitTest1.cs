using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Web.Mvc;
using EducationLoanManagementSystem.Context;
using EducationLoanManagementSystem.Controllers;
namespace ELMES.Testing
{
    [TestClass]
    public class UnitTest1
    {
        HomeController controller = new HomeController();
        private EducationLoanEntities ELE = new EducationLoanEntities();
        [TestMethod]
        public void TestMethod1()
        {
            
            ViewResult result = controller.SignIn() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
      "A userId of null was inappropriately allowed.")]
        public void TestMethod2()
        {
          
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"A userId of null was inappropriately allowed.")]
        public void TestMethod3()
        {
           
            
            ViewResult result = controller.StudentProfile(12) as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "A userId of null was inappropriately allowed.")]
        public void TestMethod4()
        {
        

            ViewResult result = controller.LoanList() as ViewResult;

            Assert.IsNull(result);
        }
        [TestMethod]
       
        public void TestMethod5()
        {
           

            ViewResult result = controller.Admin() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]

        public void TestMethod6()
        {
           

            Student student = new Student();
            student.StudentId = 32;
            student.Email = "Email.com";
            ViewResult result = controller.SignIn(student) as ViewResult;
            
            Assert.AreEqual("User Not available", result.ViewBag.Message);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),"Unauthorized User")]
        public void Dashboard()
        {
            
            ViewResult result = controller.DashBoard() as ViewResult;
            var lt = ELE.LoanTracks.Where(m => m.StudentId == 12).FirstOrDefault();
            Assert.AreEqual(lt.LoanStatus, result.ViewBag.loanMessage);
        }
        
    }
}
