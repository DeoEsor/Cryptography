using CryptographyLib.Interfaces;
using CryptographyLib.KeyExpanders;

namespace CryptographyLib.Symmetric.FeistelNetwork
{
	public abstract class SymmetricEncryptorBase : ISymmetricEncryptor
	{
		private IExpandKey _expandKey;
		
		protected SymmetricEncryptorBase(IExpandKey expandKey)
		{
			_expandKey = expandKey;
		}
		
		public IExpandKey ExpandKey
		{
			get => _expandKey;
		}

		public abstract byte[] Encrypt(byte[] value);

		public abstract byte[] Decrypt(byte[] value);

		protected virtual byte[] EncryptRound(byte[] value)
		{
			throw new NotImplementedException();
		}

		protected virtual byte[] DecryptRound(byte[] value)
		{
			throw new NotImplementedException();
		}
	}
}
