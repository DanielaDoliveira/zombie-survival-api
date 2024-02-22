using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using zombie.Data;
using zombie.Data.DTOs;
using zombie.Models;

namespace zombie.Controllers;


[ApiController]
[Route("[controller]")]
public class RankingController : ControllerBase
{
    private RankingContext _context;
    private IMapper _mapper;


    public RankingController(RankingContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpPost]
    public IActionResult CreateRanking([FromBody] CreateRankingDTO rankingDTO)
    {
        Ranking rank = _mapper.Map<Ranking>(rankingDTO);
        _context.RankingBoard.Add(rank);
        _context.SaveChanges();



        return Ok(rank);
    }

    [HttpGet]
    public IEnumerable<ReadRankingDTO> Read([FromQuery] int take = 10, [FromQuery] int skip = 0)
    {

        return _mapper.Map<List<ReadRankingDTO>>(_context.RankingBoard.FromSqlRaw($"SELECT Id, UserName, SurvivalTime FROM RankingBoard ORDER BY RankingBoard.SurvivalTime ").Skip(skip).Take(take).ToList());



    }
    [HttpDelete("{id}")]
    public IActionResult DeleteData(int id)
    {

        Ranking rank = _context.RankingBoard.FirstOrDefault((rank => rank.Id == id));


        if (id == null)
        {
            return NotFound();

        }


        _context.Remove(rank);
        _context.SaveChanges();
        return NoContent();


    }




}