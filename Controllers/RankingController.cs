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
        //     return Ok(rank);

        return CreatedAtAction(nameof(ReadByID), new { Id = rank.Id }, rankingDTO);

    }

    [HttpGet]
    public IEnumerable<ReadRankingDTO> Read([FromQuery] int take = 10)
    {

        return _mapper.Map<List<ReadRankingDTO>>(_context.RankingBoard.FromSqlRaw($"SELECT Id, UserName, SurvivalTime FROM RankingBoard ORDER BY RankingBoard.SurvivalTime DESC").Take(take).ToList());



    }

    [HttpGet("{id}")]
    public IActionResult ReadByID(int id)
    {
        Ranking rank = _context.RankingBoard.FirstOrDefault((rank => rank.Id == id));
        if (rank != null)
        {
            ReadRankingDTO rankDTO = _mapper.Map<ReadRankingDTO>(rank);
            return Ok(rankDTO);

        }
        return NotFound();
    }

}