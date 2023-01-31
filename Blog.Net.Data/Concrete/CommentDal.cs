using Blog.Net.Core.Data.Concrete;
using Blog.Net.Core.Extensions;
using Blog.Net.Data.Abstract;
using Blog.Net.Entities.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Blog.Data.Concrete
{
    public class CommentDal : MongoDbRepositoyBase<Comment>, ICommentDal
    {
        private IMongoCollection<Comment> _collection;
        private MongoDbSettings _settings;
        public CommentDal(IOptions<MongoDbSettings> options) : base(options)
        {
            _settings = options.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.Database);
            _collection = database.GetCollection<Comment>(GetCollectionName(typeof(Comment)));
        }
        private static string GetCollectionName(Type documentType)
        {
            return documentType.Name;
        }
        public List<Comment> GetByPostId(string id)
        {
            return _collection.Find(c => c.PostId == id).ToList();
        }
    }
}
