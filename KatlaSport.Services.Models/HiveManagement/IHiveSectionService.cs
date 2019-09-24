using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatlaSport.Services.HiveManagement
{
    /// <summary>
    /// Represents a hive section service.
    /// </summary>
    public interface IHiveSectionService
    {
        /// <summary>
        /// Gets a list of hive sections.
        /// </summary>
        /// <returns>A <see cref="Task{List{HiveSectionListItem}}"/>.</returns>
        Task<List<HiveSectionListItem>> GetHiveSectionsAsync();

        /// <summary>
        /// Gets a hive section.
        /// </summary>
        /// <param name="id">A hive section identifier.</param>
        /// <returns>A <see cref="Task{HiveSection}"/>.</returns>
        Task<HiveSection> GetHiveSectionAsync(int id);

        /// <summary>
        /// Create a hive section.
        /// </summary>
        /// <param name="createRequest">A new hive section.</param>
        /// <returns>A <see cref="Task{HiveSection}"/>.</returns>
        Task<HiveSection> CreateHiveSectionAsync(UpdateHiveSectionRequest createRequest);

        /// <summary>
        /// Update a hive section.
        /// </summary>
        /// <param name="hiveSectionId">A hive section id.</param>
        /// <param name="updateRequest">An update hive section.</param>
        /// <returns>A <see cref="Task{HiveSection}"/>.</returns>
        Task<HiveSection> UpdateHiveSectionAsync(int hiveSectionId, UpdateHiveSectionRequest updateRequest);

        /// <summary>
        /// Delete a hive section.
        /// </summary>
        /// <param name="hiveSectionId">A hive section id.</param>
        /// <returns>A <see cref="Task{HiveSection}"/>.</returns>
        Task DeleteHiveSectionAsync(int hiveSectionId);

        /// <summary>
        /// Gets a list of hive sections for specified hive.
        /// </summary>
        /// <param name="hiveId">A hive identifier.</param>
        /// <returns>A <see cref="Task{List{HiveSectionListItem}}"/>.</returns>
        Task<List<HiveSectionListItem>> GetHiveSectionsAsync(int hiveId);

        /// <summary>
        /// Sets deleted status for a hive section.
        /// </summary>
        /// <param name="hiveSectionId">A hive section identifier.</param>
        /// <param name="deletedStatus">Status.</param>
        /// <returns>A <see cref="Task"/>.</returns>
        Task SetStatusAsync(int hiveSectionId, bool deletedStatus);
    }
}
