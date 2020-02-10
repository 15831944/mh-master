using GalaSoft.MvvmLight;
using System.ComponentModel;

namespace Hao.Launcher.Model
{
	/// <summary>
	/// ��ǰ��ͼƬ���
	/// </summary>
	public class ImagesItem : ViewModelBase
	{
		private bool _isNew;

		/// <summary>
		/// ��ǰ��ͼƬ·��
		/// </summary>
		public string BigImage
		{
			get;
			set;
		}



		/// <summary>
		/// �Ƿ�������
		/// </summary>
		public bool IsNew
		{
			get
			{
				return this._isNew;
			}
			set
			{
				base.Set<bool>(ref this._isNew, value, false, "IsNew");
			}
		}

		/// <summary>
		/// ��ǰ�Ƿ���
		/// </summary>
		public string Link
		{
			get;
			set;
		}

		public bool OpenLink { get; set; } = true;

		public string SmallImage
		{
			get;
			set;
		}

		public ImagesItem()
		{
			base.PropertyChanged += new PropertyChangedEventHandler(this.ImagesItem_PropertyChanged);
		}

		private void ImagesItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "IsNew")
			{
				base.MessengerInstance.Send<ImagesItem>(this, "IsNew");
			}
		}
	}
}