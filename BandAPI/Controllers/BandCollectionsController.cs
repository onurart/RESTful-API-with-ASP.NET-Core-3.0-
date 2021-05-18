using AutoMapper;
using BandAPI.Models;
using BandAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Controllers
{
    [Route("api/[bandcollections]")]
    [ApiController]
    public class BandCollectionsController : ControllerBase
    {
        private readonly IBandAlbumRepository _bandAlbumRepository;
        private readonly Mapper _mapper;

        public BandCollectionsController(IBandAlbumRepository bandAlbumRepository, Mapper mapper)
        {
            _bandAlbumRepository = bandAlbumRepository ??
                throw new ArgumentNullException(nameof(bandAlbumRepository));
            _mapper = mapper ??
                   throw new ArgumentNullException(nameof(mapper));

        }
        [HttpPost]
        public ActionResult<IEnumerable<BandDto>> CreateBandCollection([FromBody]
        IEnumerable<BandForCreatingDto> bandCollection)
        {
            var bandEntities = _mapper.Map<IEnumerable<Entities.Band>>(bandCollection);
            foreach (var band in bandEntities)
            {
                _bandAlbumRepository.AddBand(band);
            }
            _bandAlbumRepository.save();
            return Ok();
        }

        [HttpOptions]
        public IActionResult GetBandOptions()
        {
            Response.Headers.Add("Allow","GET,POST,DELETE,HEAD,OPTIONS");
            return Ok();
        }
    }
}
