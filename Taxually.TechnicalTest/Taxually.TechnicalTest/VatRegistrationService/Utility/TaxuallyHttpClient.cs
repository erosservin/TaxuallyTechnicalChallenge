﻿namespace Taxually.TechnicalTest.VatRegistrationService.Utility;

public class TaxuallyHttpClient : ITaxuallyHttpClient
{
    public Task PostAsync<TRequest>(string url, TRequest request)
    {
        // Actual HTTP call removed for purposes of this exercise
        return Task.CompletedTask;
    }
}