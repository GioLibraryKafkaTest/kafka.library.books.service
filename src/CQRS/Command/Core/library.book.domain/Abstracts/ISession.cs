﻿using MongoDB.Driver;

namespace command.books.domain.Abstracts;
public interface ISession
{
  Task<IClientSessionHandle> BeginSessionAsync(CancellationToken cancellationToken);
  void BeginTransaction(IClientSessionHandle clientSessionHandle);
  Task CommitTransactionAsync(IClientSessionHandle clientSessionHandle, CancellationToken cancellationToken);
  Task RollbackTransactionAsync(IClientSessionHandle clientSessionHandle, CancellationToken cancellationToken);
  void DisposeSession(IClientSessionHandle clientSessionHandle);
}