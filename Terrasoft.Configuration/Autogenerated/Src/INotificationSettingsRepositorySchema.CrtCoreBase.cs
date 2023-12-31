﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationSettingsRepositorySchema

	/// <exclude/>
	public class INotificationSettingsRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationSettingsRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationSettingsRepositorySchema(INotificationSettingsRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc33ae41-bf6c-4f6c-b52a-7eaf39e99da6");
			Name = "INotificationSettingsRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,205,78,196,32,20,133,215,211,164,239,112,51,110,52,49,101,175,117,92,184,152,116,163,137,29,31,128,161,151,14,70,126,2,183,139,198,248,238,66,167,54,216,49,145,176,225,92,206,199,185,128,225,26,131,227,2,225,128,222,243,96,37,85,79,214,72,213,15,158,147,178,6,202,226,179,44,54,67,80,166,135,118,12,132,250,190,44,162,114,229,177,79,245,198,16,122,25,9,119,208,60,91,82,82,137,201,216,34,81,244,132,87,116,54,40,178,126,140,166,56,25,99,80,135,65,107,238,199,221,188,94,24,96,37,152,12,18,32,204,24,240,11,167,250,161,176,12,227,134,227,135,18,160,22,210,255,97,82,95,23,113,38,97,143,244,43,6,40,205,123,4,213,161,73,34,122,144,214,67,112,40,210,170,131,32,78,168,121,181,240,216,26,88,59,238,185,6,19,111,251,97,155,32,52,182,147,231,173,233,182,187,151,227,59,10,154,41,16,165,170,102,147,225,111,127,158,236,48,58,76,136,188,89,160,40,194,138,178,31,84,151,250,202,55,54,169,171,235,169,178,202,116,11,73,125,132,203,163,110,226,235,111,190,206,63,0,77,119,254,4,101,17,149,124,124,3,115,151,176,131,87,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc33ae41-bf6c-4f6c-b52a-7eaf39e99da6"));
		}

		#endregion

	}

	#endregion

}

