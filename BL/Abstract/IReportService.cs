using DTO;
using System.Collections.Generic;

namespace BL.Abstract
{
    public interface IReportService
    {
        #region Public Methods

        ResultModel GetAll();
        
        #endregion Public Methods
    }
}