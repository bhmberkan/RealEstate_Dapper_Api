using RealEstate_Dapper_Api.Dtos.SubFeatureDtos;

namespace RealEstate_Dapper_Api.Repositories.SubFeatureRepository
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDtos>> GetAllSubFeaturesAsync();
    }
}
