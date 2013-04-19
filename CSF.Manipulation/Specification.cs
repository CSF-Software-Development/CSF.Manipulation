using System;

namespace CSF.Manipulation
{
  /// <summary>
  /// Represents a specification for manipulation of an object of type <typeparamref name='T' />.
  /// </summary>
  /// <typeparam name='T'>
  /// The type of object that this specification is built for.
  /// </typeparam>
  public class Specification<T> where T : class
  {
    #region fields

    private T _stub;

    #endregion

    #region properties

    /// <summary>
    /// Gets a stub object that may be manipulated by client code.
    /// </summary>
    /// <value>
    /// The stub object.
    /// </value>
    public T Stub
    {
      get {
        return _stub;
      }
    }

    #endregion

    #region methods

    /// <summary>
    /// Creates a 'preview' object instance by 'overlaying' the modifications made to the <see cref="Stub"/> on top of
    /// an <paramref name="original"/> object instance.
    /// </summary>
    /// <returns>
    /// An object instance that represents a preview of the state of the <paramref name="original"/> object if the
    /// changes were applied to it.
    /// </returns>
    /// <param name='original'>
    /// An object holding the 'original'/unmodified state of the target object.
    /// </param>
    public T CreatePreview(T original)
    {
      // TODO: Write this implementation
      throw new NotImplementedException();
    }

    /// <summary>
    /// Applies the changes made to the <see cref="Stub"/> to the <paramref name="original"/> object, modifying it
    /// appropriately.
    /// </summary>
    /// <param name='original'>
    /// The object to be modified by this action.
    /// </param>
    public void ApplyTo(T original)
    {
      // TODO: Write this implementation
      throw new NotImplementedException();
    }

    #endregion

    #region constructor

    /// <summary>
    /// Initializes a new instance of the <c>Specification</c> class.
    /// </summary>
    public Specification()
    {
      // TODO: Write this implementation
      throw new NotImplementedException();
    }

    #endregion
  }
}

