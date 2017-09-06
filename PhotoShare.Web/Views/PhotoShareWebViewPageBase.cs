using Abp.Web.Mvc.Views;

namespace PhotoShare.Web.Views
{
    public abstract class PhotoShareWebViewPageBase : PhotoShareWebViewPageBase<dynamic>
    {

    }

    public abstract class PhotoShareWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PhotoShareWebViewPageBase()
        {
            LocalizationSourceName = PhotoShareConsts.LocalizationSourceName;
        }
    }
}