using Infrastructure.Factories;
using Infrastructure.Model;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class UserService(UserRepository repository, AddressService addressService)
{
    private readonly UserRepository _repository = repository;
    private readonly AddressService _addressService = addressService;



    public async Task<ResponseResult> CreateUserAsync(SignUpModel model )
    {
        try
        {
            var result = await _repository.AlreadyExistAsync(x => x.Email == model.Email);
            if (result.StatusCode != StatusCode.EXISTS) 
            {
                result = await _repository.CreateOneAsync(UserFactory.Create(model));
                if (result.StatusCode != StatusCode.OK)
                    return ResponseFactory.Ok("User was created successfully.");

                return result;
            }

            return result;
        }
        catch (Exception ex) { return ResponseFactory.Error(ex.Message); }
    }
}
