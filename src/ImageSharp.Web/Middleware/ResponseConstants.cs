// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Threading.Tasks;

namespace SixLabors.ImageSharp.Web.Middleware
{
    /// <summary>
    /// Contains constants related to HTTP respose codes.
    /// </summary>
    public static class ResponseConstants
    {
        /// <summary>
        /// The HTTP 200 OK success status response code indicates that the request has succeeded.
        /// </summary>
        public const int Status200Ok = 200;

        /// <summary>
        /// The HTTP 304 Not Modified client redirection response code indicates that there is no need
        /// to retransmit the requested resources.
        /// </summary>
        public const int Status304NotModified = 304;

        /// <summary>
        /// The HTTP 412 Precondition Failed client error response code indicates that access to the target
        /// resource has been denied.
        /// </summary>
        public const int Status412PreconditionFailed = 412;

        /// <summary>
        /// An empty completed task.
        /// </summary>
        public static readonly Task CompletedTask = CreateCompletedTask();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task CreateCompletedTask()
        {
            var tcs = new TaskCompletionSource<object>();
            tcs.SetResult(null);
            return tcs.Task;
        }
    }
}
