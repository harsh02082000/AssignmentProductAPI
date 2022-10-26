﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private ArticleServices _articleService;
        public ArticlesController(ArticleServices articleService)
        {
            _articleService = articleService;
        }
        [HttpGet("GetArticles")]
        public IEnumerable<Article> GetArticles()
        {
            return _articleService.GetArticles();
        }
        [HttpGet("GetArticleById")]
        public Article GetArticleById(int articleId)
        {
            return _articleService.GetArticleByid(articleId);
        }
        [HttpPost("AddArticle")]
        public IActionResult AddArticle([FromBody] Article article)
        {
            _articleService.AddArticle(article);
            return Ok("Article created successfully!!");
        }
    }
}
