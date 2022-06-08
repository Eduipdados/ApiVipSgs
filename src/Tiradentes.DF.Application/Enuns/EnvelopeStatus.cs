using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VipSgs.Application.Enuns
{
    public enum EnvelopeStatus
    {
        any,
        created,
        deleted,
        sent,
        delivered,
        signed,
        completed,
        declined,
        timedout,
        voided
    }
}
