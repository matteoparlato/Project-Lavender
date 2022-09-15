namespace Project_Lavender.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
