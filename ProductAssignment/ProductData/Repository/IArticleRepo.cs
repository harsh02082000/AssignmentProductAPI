using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductData.Repository
{
    public interface IArticleRepo
    {
        void AddArticle(Article article);

        void UpdateArticle(Article article);

        void DeleteArticle(int articleId);

        Article GetArticleById(int articleId);
        IEnumerable<Article> GetArticles();
    }
}
