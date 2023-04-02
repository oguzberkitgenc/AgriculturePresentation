using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _GaleryPartial : ViewComponent
    {
        private readonly IImageService _imageService;
        public _GaleryPartial(IImageService imageService)
        {
            _imageService = imageService;
        }
        public IViewComponentResult Invoke()
        {
            var value = _imageService.GetListAll();
            return View(value);
        }
    }
}
