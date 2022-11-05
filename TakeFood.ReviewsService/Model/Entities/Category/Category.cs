﻿using MongoDB.Bson.Serialization.Attributes;

namespace TakeFood.ReviewsService.Model.Entities.Category;

/// <summary>
/// Category shared
/// </summary>
public class Category:ModelMongoDB
{
    /// <summary>
    /// Category's name
    /// </summary>
    [BsonElement("Name")]
    public string Name;

    [BsonElement("Type")]
    public string Type;
}
