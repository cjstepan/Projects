using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicShop.com.Data;
using MusicShop.com.Models;
using Newtonsoft.Json;
using NuGet.Protocol.Core.Types;
using System;
using System.Diagnostics;
using System.Formats.Tar;
using System.Linq;

namespace MusicShop.com.Controllers
{
    public class BrowseMusicController : Controller
    {
        private readonly MusicShopcomContext _context;
        string localGenre = "";
        public BrowseMusicController(MusicShopcomContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var genres = _context.Music.Select(m => m.Genre).Distinct().ToList();
            ViewBag.Genres = genres;
            ViewBag.Performers = Enumerable.Empty<string>(); // Initialize as empty
            ViewBag.Songs = Enumerable.Empty<object>(); // Initialize as empty

            return View();
        }

        [HttpPost]
        public IActionResult GetPerformers(string genre)
        {
            // Get the performers for the selected genre from your Music table
            localGenre = genre;
            var performers = _context.Music.Where(m => m.Genre == localGenre).Select(m => m.Performer).Distinct().ToList();
            ViewBag.Performers = performers;

            // Get the genres from your Music table
            var genres = _context.Music.Select(m => m.Genre).Distinct().ToList();
            ViewBag.Genres = genres;

            return View("Index");
        }

        [HttpPost]
        public IActionResult GetSongs(string performer)
        {
            // Get the performers for the selected genre from your Music table
            var performers = _context.Music.Where(m => m.Genre == localGenre).Select(m => m.Performer).Distinct().ToList();
            ViewBag.Performers = performers;

            // Get the genres from your Music table
            var genres = _context.Music.Select(m => m.Genre).Distinct().ToList();
            ViewBag.Genres = genres;

            var songs = _context.Music
                .Where(m => m.Performer == performer)
                .Join(_context.Price,
                        m =>m.Id,
                        p => p.Id,
                        (m, p) => new {SongId = m.Id, SongName = m.Song, DigitalPrice = p.digitalPrice, VinylPrice = p.vinylPrice, CDPrice = p.cdPrice })
                .ToList();
            ViewBag.Songs = songs;
            return View("Index");
        }

        [HttpPost]
        public IActionResult SubmitCart()
        {
            return StatusCode(200);
        }



    }
}
