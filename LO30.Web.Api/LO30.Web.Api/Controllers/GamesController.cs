using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LO30.Data.Models;
using LO30.Data.Contexts;

namespace LO30.Web.Api.Controllers
{
  public class GamesController : ApiController
  {
    public IEnumerable<Game> GetAllGames()
    {
      List<Game> games;

      using (var context = new LO30Context())
      {
        games = context.Games.ToList();
      }

      return games;
    }

    public IHttpActionResult GetGame(int gameId)
    {
      Game game;

      using (var context = new LO30Context())
      {
        game = context.Games.Where(x => x.GameId == gameId).FirstOrDefault();
      }

      if (game == null)
      {
        return NotFound();
      }
      return Ok(game);
    }
  }
}
