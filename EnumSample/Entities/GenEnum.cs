using System;

namespace EnumSample.Entities
{

    public enum AccountType : byte
    {
        SiteRegistered = 0,
        Facebook = 1,
        Google = 2,
        Twitter = 3,
    }


    public enum EpaperStatus : byte
    {
        訂閱 = 1,
        取消訂閱 = 2,
    }


    public enum BlacklistStatus : byte
    {
        否 = 0,
        是 = 1,
    }


    public enum AccountStatus : byte
    {
        未啟用 = 0,
        正常 = 1,
        黑名單 = 2,
        停用 = 3,
    }

}