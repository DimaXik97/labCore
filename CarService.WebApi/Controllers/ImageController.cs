using System.Threading.Tasks;
using CarService.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarService.WebApi.Controllers
{
	[Route("api/[controller]")]
	public class BlogController : Controller
	{
		IImageRepository _imageRepository;

		public BlogController(IImageRepository imageRepository)
		{
			_imageRepository = imageRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetImageAsync()
		{
			return Ok(/*await _imageRepository.GetAll()*/);
		}
	}
}