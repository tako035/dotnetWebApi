using System;
namespace Business.Concrete.Constants
{
    public static class Messages
    {
        public static string dataAdded = "Veri kaydı başarılı.";
        public static string dataUpdated = "Veri güncelleme başarılı.";
        public static string dataDeleted = "Kayıt silindi.";

        public static string fieldRequired = "Bu alan zorunludur.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string LoginSuccessfull = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı kaydı mevcut!";
        public static string UserRegistered = "Kullanıcı kaydı başarılı.";
        public static string AccessTokenCreated = "Giriş Token'ı oluşturuldu.";
        
        public static string DatabaseConnectionError = "Veritabanına ulaşılamıyor.";
    }
}

