namespace Taxually.TechnicalTest.VatRegistrationService.Utility;

public interface ITaxuallyQueueClient
{
    Task EnqueueAsync<TPayload>(string queueName, TPayload payload);
}