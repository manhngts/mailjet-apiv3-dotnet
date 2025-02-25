﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Mailjet.Client.TransactionalEmails;
using Mailjet.Client.TransactionalEmails.Response;

namespace Mailjet.Client
{
    public interface IMailjetClient
    {
        Task<MailjetResponse> GetAsync(MailjetRequest request);
        Task<MailjetResponse> PostAsync(MailjetRequest request);
        Task<MailjetResponse> PutAsync(MailjetRequest request);
        Task<MailjetResponse> DeleteAsync(MailjetRequest request);

        /// <summary>
        /// Sends a single transactional email using send API v3.1
        /// </summary>
        Task<TransactionalEmailResponse> SendTransactionalEmailAsync(TransactionalEmail transactionalEmail, bool isSandboxMode = false, bool advanceErrorHandling = true);

        /// <summary>
        /// Sends transactional emails using send API v3.1
        /// </summary>
        Task<TransactionalEmailResponse> SendTransactionalEmailsAsync(IEnumerable<TransactionalEmail> transactionalEmails, bool isSandboxMode = false, bool advanceErrorHandling = true);
    }
}
