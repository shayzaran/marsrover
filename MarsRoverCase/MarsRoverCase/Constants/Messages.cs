using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Constants
{
    public static class Messages
    {
        public static string InvalidStartCoordinate = "Geçersiz başlangıç koordinatı girildi.";
        public static string OutOfBoundriesPlateauCoordinates = "Plato sınırları dışında koordinat girildi.";
        public static string UpperLimitsMustBeGreaterThanZero = "Üst limitler tam sayı ve sıfırdan büyük olmalı";
        public static string CurrentCoordinateResult = "{0} {1} {2}";
        public static string AnErrorOccured = "Bir hata oluştu!";
        public static string InvalidRotationDirection = "Geçersiz dönüş yönü girildi.";
    }
}
