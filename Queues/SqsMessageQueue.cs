﻿using Amazon.SQS;
using Amazon.SQS.Model;

namespace Utils.IO.Server.Queues
{
	public class SqsMessageQueue : ISqsMessageQueue
	{
		private readonly IAmazonSQS _amazonSQS;

		public SqsMessageQueue(IAmazonSQS amazonSQS) => _amazonSQS = amazonSQS;

		public Task<ReceiveMessageResponse> ReceiveMessageAsync(
			ReceiveMessageRequest request,
			CancellationToken cancellationToken = default)
		{
			return _amazonSQS.ReceiveMessageAsync(request, cancellationToken);
		}
	}
}