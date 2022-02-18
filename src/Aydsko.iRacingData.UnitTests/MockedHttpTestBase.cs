﻿// © 2022 Adrian Clark
// This file is licensed to you under the MIT license.

namespace Aydsko.iRacingData.UnitTests;

public class MockedHttpTestBase : IDisposable
{
    protected MockedHttpMessageHandler MessageHandler { get; set; } = null!;
    protected HttpClient HttpClient { get; set; } = null!;
    private bool disposedValue;

    protected void BaseSetUp()
    {
        MessageHandler = new MockedHttpMessageHandler();
        HttpClient = new HttpClient(MessageHandler);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                MessageHandler?.Dispose();
                HttpClient?.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}