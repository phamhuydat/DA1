using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Share.Consts
{
    public static class DB
    {
        public static class SEOEntity
        {
            public const short TITLE_LENGTH = 200;
            public const short DESC_LENGTH = 1000;
            public const short KEYWORD_LENGTH = 100;
            public const short IMAGEPATH_LENGTH = 1000;
        }
        public static class AppRole
        {
            public const string TABLE_NAME = "AppRole";
            public const short NAME_LENGTH = 50;
            public const short DESC_LENGTH = 100;
        }
        public static class AppRolePermission
        {
            public const string TABLE_NAME = "AppRolePermission";
        }
        public static class AppUser
        {
            public const string TABLE_NAME = "AppUser";
            public const short USERNAME_LENGTH = 200;
            public const short PWD_LENGTH = 200;
            public const short FULLNAME_LENGTH = 50;
            public const short PHONE_LENGTH = 20;
            public const short EMAIL_LENGTH = 200;
            public const short ADDRESS_LENGTH = 100;
            public const short AVATAR_LENGTH = 250;
        }
        public static class MstPermission
        {
            public const string TABLE_NAME = "MstPermission";
            public const short CODE_LENGTH = 50;
            public const short TABLE_LENGTH = 50;
            public const short GROUPNAME_LENGHT = 100;
            public const short DESC_LENGHT = 100;
        }

        public static class AppMailSubscriber
        {
            public const string TABLE_NAME = "AppMailSubscriber";
            public const short EMAIL_LENGTH = 200;
        }

        public static class AppContact
        {
            public const string TABLE_NAME = "AppContact";
            public const short FULLNAME_LENGTH = 100;
            public const short EMAIL_LENGTH = 200;
            public const short PHONE_LENGTH = 20;
            public const short CONTENT_LENGTH = 2000;
        }

        public static class SystemEnv
        {
            public const string TABLE_NAME = "SystemEnv";
            public const short KEY_LENGTH = 200;
        }

        public static class AppSlider
        {
            public const string TABLE_NAME = "AppSlider";
            public const short IMAGE_PATH_LENGTH = 500;
            public const short LINK = 1000;
        }

        public static class AppPolicy
        {
            public const string TABLE_NAME = "AppPolicy";
            public const short TITLE_LENGTH = 200;
            public const short SLUG_LENGTH = 200;
            public const short COVER_IMG_PATH_LENGTH = 500;
            public const short LIKE_DEFAULT_VALUE = 0;
        }

        public static class AppVerifyCode
        {
            public const string TABLE_NAME = "AppVerifyCode";
            public const string DEFAULT_DATE = "GETDATE()";
            public const bool IS_VERIFIED = false;
        }

        public static class AppNewsCategory
        {
            public const string TABLE_NAME = "AppNewsCategory";
            public const short TITLE_LENGTH = 300;
            public const short SLUG_LENGTH = 300;
            public const short COVER_IMG_PATH_LENGTH = 1000;
            public const string DEFAULT_DATE = "GETDATE()";
        }

        public static class AppNews
        {
            public const string TABLE_NAME = "AppNews";
            public const short TITLE_LENGTH = 500;
            public const short SLUG_LENGTH = 500;
            public const short SUMMARY_LENGTH = 500;
            public const short IMAGE_LENGTH = 300;
            public const string DEFAULT_DATE = "GETDATE()";
            public const bool PUBLIC_NEWS = true;
            public const string DEFAULT_VALUE = null;
            public const short COUNT = 0;
        }

        public static class AppBranch
        {
            public const string TABLE_NAME = "AppBranch";
            public const short MAX_LENGTH = 500;
        }

        public static class AppProductCategory
        {
            public const string TABLE_NAME = "AppProductCategory";
            public const short NAME_LENGTH = 200;
            public const short IMG_LENGTH = 500;
            public const short GROUP_NAME_LENGTH = 300;
            public const short LENGTH_CATEGORY = 200;
            public const short LENGTH_LEVEL = 5;
            public const bool DEFAULT_VALUE = false;
            public const int DEFAULT_CONTENT = 1000;
            public const int IPHONE = 1;
            public const int IPAD = 2;
            public const int MAC = 3;
            public const int WATCH = 4;
            public const int ACCESSORY = 5;
        }

        public static class AppDiscountCode
        {
            public const string TABLE_NAME = "AppDiscountCode";
            public const short CODE_LENGTH = 100;
            public const short DES_LENGTH = 1000;
        }

        public static class MstOrderStatus
        {
            public const string TABLE_NAME = "MstOrderStatus";
            public const short NAME_LENGTH = 200;
        }

        public static class OrderStatusId
        {
            public const short STATUS_PENDING = 1;
            public const short STATUS_PROCESSING = 2;
            public const short STATUS_DONE = 3;
            public const short STATUS_CANCELED = 4;
            public const string STATUS_PENDING_NAME = "Đang xử lý";
            public const string STATUS_PROCESSING_NAME = "Đang giao hàng";
            public const string STATUS_DONE_NAME = "Đã giao hàng";
            public const string STATUS_CANCELED_NAME = "Đã từ chối";
        }

        public static class MstProductBrand
        {
            public const string TABLE_NAME = "MstProductBrand";
            public const short NAME_LENGTH = 200;
            public const short IMG_LENGTH = 1000;
            public const short SLUG_LENGTH = 500;
        }

        public static class MstProductColor
        {
            public const string TABLE_NAME = "MstProductColor";
            public const short COLOR_NAME_LENGTH = 100;
        }

        public static class AppProductQuantity
        {
            public const string TABLE_NAME = "AppProductQuantity";
            public const short MIN_VALUE = 0;
        }

        public static class AppOrder
        {
            public const string TABLE_NAME = "AppOrder";
            public const short CUS_NAME_LENGTH = 50;
            public const short CUS_PHONE_LENGTH = 20;
            public const short CUS_EMAIL_LENGTH = 200;
            public const short DELIVERY_ADDRESS_LENGTH = 100;
            public const short CUS_NOTE_LENGTH = 500;
        }

        public static class AppProduct
        {
            public const string TABLE_NAME = "AppProduct";
            public const short SLUG_LENGTH = 500;
            public const short STAMP_PATH_LENGTH = 500;
            public const short PRODUCTNAME_LENGTH = 200;
            public const short PRODUCT_CODE_LENGTH = 300;
            public const short DEFAULT_VALUE = 0;
            public const short TAG_LENGTH = 5000;
        }

        public static class AppProductImage
        {
            public const string TABLE_NAME = "AppProductImage";
            public const short IMAGE_PATH_LENGTH = 1000;
        }

        public static class AppOrderDetail
        {
            public const string TABLE_NAME = "AppOrderDetail";
            public const short PRODUCT_NAME_LENGTH = 500;
            public const short IMG_PATH_LENGTH = 1000;
        }
        public static class AppProductDetail
        {
            public const string TABLE_NAME = "AppProductDetail";
        }

    }
}
