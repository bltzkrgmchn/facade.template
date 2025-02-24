﻿namespace Facade.Template.WebApi
{
    /// <summary>
    /// Команда получения Placeholder.
    /// </summary>
    public class GetPlaceholderCommand
    {
        /// <summary>
        /// Получает или задает идентификатор Placeholder.
        /// </summary>
        public string Id { get; set; }
    }
}