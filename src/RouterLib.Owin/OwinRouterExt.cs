using Owin;

namespace RouterLib.Owin
{
    /// <summary>
    /// Extension methods to simplify usage of router middleware.
    /// </summary>
    public static class  OwinRouterExt
    {
        /// <summary>
        /// Add router to the pipeline
        /// </summary>
        /// <param name="app">Application builder.</param>
        /// <param name="options">Router options <see cref="IRouterMwOptions"/></param>
        public static void UseOwinRouter(this IAppBuilder app, IRouterMwOptions options)
        {
            options.Validate();
            app.Use(typeof(RouterMw), options);
        }
    }
}
