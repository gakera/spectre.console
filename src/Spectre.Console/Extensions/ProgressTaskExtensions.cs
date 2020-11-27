using System;

namespace Spectre.Console
{
    /// <summary>
    /// Contains extension methods for <see cref="ProgressTask"/>.
    /// </summary>
    public static class ProgressTaskExtensions
    {
        /// <summary>
        /// Sets the task description.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <param name="description">The description.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static ProgressTask Description(this ProgressTask task, string description)
        {
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            task.Description = description;
            return task;
        }

        /// <summary>
        /// Sets the max value of the task.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <param name="value">The max value.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        public static ProgressTask MaxValue(this ProgressTask task, double value)
        {
            if (task is null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            task.MaxValue = value;
            return task;
        }
    }
}
