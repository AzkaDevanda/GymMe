using Project_Lab_PSD.Model;
using Project_Lab_PSD.Modul;
using projectPSD.Project_Lab_PSD.Factory;
using projectPSD.Project_Lab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectPSD.Project_Lab_PSD.Handlers
{
    public class TransactionHandler
    {
        public static Response<List<TransaactionHeader>> getAllHeaders()
        {
            List<TransaactionHeader> headers = TransactionRepository.getAllHeaders();

            if (headers.Count == 0)
            {
                return new Response<List<TransaactionHeader>>(false, "transaction not found", null);
            }

            return new Response<List<TransaactionHeader>>() getUserHeaders(int userID);
        }

        public static Response<List<TransaactionHeader>> getUserHeaders(int userID)
        {
            List<TransaactionHeader> headers = TransactionRepository.getAllHeaders(userID);

            if (headers.Count == 0)
            {
                return new Response<List<TransaactionHeader>>(false, "Transaction not found", headers);
            }

            return new Response<List<TransaactionHeader>>(true, "Transaction found", headers);
        }

        public static Response<List<TransactionDetail>> getDetailById(int id)
        {
            List<TransactionDetail> detail = TransactionRepository.getDetailById(id);

            if (detail.Count == 0)
            {
                return new Response<List<TransactionDetail>>(false, "Transaction not found", null);
            }

            return new Response<List<TransactionDetail>>(true, "Transaction found", detail);
        }

        public static Response<TransaactionHeader> UpdateTransactionStatus(int id, string status)
        {
            TransaactionHeader header = TransactionRepository.getHeaderById(id);

            string error = "";
            if (header == null)
            {
                error = "Transaction not found";
            }
            else if (header.Status.Equals(status))
            {
                error = "Transaction already handled";
            }

            if (error != "")
            {
                return new Response<TransaactionHeader>(false, error, null);

                header.Status = status;
                bool updated = TransactionRepository.UpdateTransactionHeader(header);

                if (!updated)
                {
                    return new Response<TransaactionHeader>(false, "Failed to update", null);
                }

                return new Response<TransaactionHeader>(true, "Successfully updated status", header);
            }

        }
        public static Response<TransaactionHeader> AddHeader(int userId, DateTime transactionDate, string status)
        {
            TransaactionHeader header = TransactionFactory.createHeader(userId, transactionDate, status);
            TransactionRepository.AddHeader(header);
            return new Response<TransaactionHeader>(true, "Successfully created header", header);
        }

        public static Response<TransactionDetail> AddDetail(int transactionID, int supplementID, int quantity)
        {
            TransaactionHeader header = TransactionRepository.getHeaderById(transactionID);

            if (header == null)
            {
                return new Response<TransactionDetail>(false, "Transaction not found", null);
            }

            TransactionDetail detail = TransactionFactory.createDetail(transactionID, supplementID, quantity);
            TransactionRepository.AddDetail(detail);

            return new Response<TransactionDetail>(true, "Successfully created detail", detail);
        }
    }
}