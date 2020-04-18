﻿using System.Threading.Tasks;
using MijnSauna.Common.DataTransferObjects.Sessions;

namespace MijnSauna.Common.Client.Interfaces
{
    public interface ISessionClient
    {
        Task<GetActiveSessionResponse> GetActiveSession();

        Task<CreateSessionResponse> CreateSession(CreateSessionRequest request);
    }
}