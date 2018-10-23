using KikapWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KikapWebSite.Controllers
{
    public class AccountController : Controller
    {
        //public ActionResult Register()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Register(RegisterModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        MembershipCreateStatus status;
        //        Membership.CreateUser(model.UserName, model.Password, model.Email, "soru", "cevap", true, out status);
        //        FormsAuthentication.SetAuthCookie(model.UserName, false);
        //        if (status == MembershipCreateStatus.Success)
        //        {
        //            MigrateShoppingCart(model.UserName);
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", ErrorCodeToString(status));
        //        }
        //    }


        //    return View(model);
        //}
        //public ActionResult LogOn()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult LogOn(LogOnModel model, string returnUrl)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (Membership.ValidateUser(model.UserName, model.Password))
        //        {
        //            MigrateShoppingCart(model.UserName);
        //            FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
        //            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
        //            {
        //                return Redirect(returnUrl);
        //            }

        //            else
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }

        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
        //        }

        //    }

        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult ChangePassword(ChangePasswordModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        bool changePaswordSuccessed;

        //        try
        //        {
        //            MembershipUser currentUser = Membership.GetUser(User.Identity.Name, true);
        //            changePaswordSuccessed = currentUser.ChangePassword(model.OldPassword, model.NewPassword);

        //        }
        //        catch
        //        {
        //            changePaswordSuccessed = false;
        //        }
        //        if (changePaswordSuccessed)
        //        {
        //            return RedirectToAction("ChangePasswordSuccess");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Başarısız!");
        //        }

        //    }
        //    return View(model);
        //}
        //private static string ErrorCodeToString(MembershipCreateStatus status)
        //{
        //    switch (status)
        //    {
        //        case MembershipCreateStatus.DuplicateEmail:
        //            return "Aynı mail zaten var!";
        //        case MembershipCreateStatus.DuplicateUserName:
        //            return "Aynı kullanıcı adı zaten var!";
        //        case MembershipCreateStatus.InvalidAnswer:
        //            return "Güvenlik sorusu cevabı geçerli değil!";
        //        case MembershipCreateStatus.InvalidEmail:
        //            return "Geçersiz elektronik posta adresi!";
        //        case MembershipCreateStatus.InvalidPassword:
        //            return "Geçersiz şifre!";
        //        case MembershipCreateStatus.InvalidQuestion:
        //            return "Güvenlik sorusu geçerli değil!";
        //        case MembershipCreateStatus.InvalidUserName:
        //            return "Geçersiz kullanıcı adı!";
        //        case MembershipCreateStatus.ProviderError:
        //            return "Sistem yöneticisine başvurun!";
        //        case MembershipCreateStatus.UserRejected:
        //            return "Kullanıcı oluşturma işlemi iptal edildi! Eğer hata devam ederse yöneticiye başvurun.";
        //        default:
        //            return "Bilinmeyen bir hata oluştu!";
        //    }
        //}

        //BURDAN DEVAM EDERsin
    }
}