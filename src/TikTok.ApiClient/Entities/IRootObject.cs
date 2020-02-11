﻿namespace TikTok.ApiClient
{
    public interface IRootObject<TWrapper, TEntity> where TWrapper : IWrapper<TEntity> where TEntity : IApiEntity
    {
        string Message { get; set; }
        string code { get; set; }
        TWrapper Data { get; set; }
    }
}