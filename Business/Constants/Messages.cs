using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Success Messages
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductListed = "Ürün listelendi.";
        public static string ProductDetailsListed = "Ürün ve kategori adı listelendi.";

        //Error Messages
        public static string ProductNameInvalid = "Ürün adı en az 2 karakter içermelidir!";
        public static string MainTenanceTime = "Sistem bakımda.";
        public static string ProductNotBeAdded = "Ürün eklenemedi.";
        public static string ProductNotBeUpdated = "Ürün güncellenemedi.";
        public static string ProductNotBeDeleted = "Ürün silinemedi.";
        public static string ProductNotBeListed = "Ürünler listelenemedi.";
        public static string ProductNotBeDetailsListed = "Ürün ve kategori adı listelenemedi.";
        public static string WithStartA = "Ürünler A harfi ile başlamalı.";
    }
}
