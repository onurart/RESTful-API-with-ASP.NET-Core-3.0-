
using AutoMapper;
using BandAPI.Helpers;
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
    [Route("api/bands")]
    [ApiController]
    public class BandsController : ControllerBase
    {
        private readonly IBandAlbumRepository _bandAlbumRepository;
        private readonly Mapper _mapper;

        public BandsController(IBandAlbumRepository bandAlbumRepository, Mapper mapper)
        {
            _bandAlbumRepository = bandAlbumRepository ??
                throw new ArgumentNullException(nameof(bandAlbumRepository));
            _mapper = mapper ??
                   throw new ArgumentNullException(nameof(mapper));

        }
        [HttpGet]
        [HttpHead]
        public ActionResult<IEnumerable<BandDto>> GetBands([FromQuery] 
        BandsResourceParameter bandsResourceParameter)
        {


            var bandsFromRepo = _bandAlbumRepository.GetBands(bandsResourceParameter);
           return Ok(_mapper.Map<IEnumerable<BandDto>>
            (bandsFromRepo));
        }
        [HttpGet("{bandId}", Name ="GetBand")]
        public IActionResult GetBand(Guid bandId)
        {
            var bandFromRepo = _bandAlbumRepository.GetBand(bandId);
            if (bandFromRepo == null)
                return NotFound();
            return Ok(bandFromRepo);
        }

        [HttpPost]
        public ActionResult<BandDto> CreateBand([FromBody] BandForCreatingDto band)
        {
            var bandEntity = _mapper.Map<Entities.Band>(band);
            _bandAlbumRepository.AddBand(bandEntity);
            _bandAlbumRepository.save();

            var banToReturn = _mapper.Map <BandDto>(bandEntity);
            return CreatedAtRoute("GetBand", new { bandId = banToReturn.Id }, banToReturn);
        }
    }
}
