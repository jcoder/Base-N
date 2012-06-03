package base_n;

/**
 * Hexadecimal base converter
 * @author	jcoder
 */
public class Base16 extends BaseNConverter
{
    public static final String ALPHABET = "0123456789ABCDEF";

    public Base16() {
        super(ALPHABET);
    }

    protected int ResolveCharToIndex(char c)
    {
        c = Character.toUpperCase(c);
        return super.resolveCharToIndex(c);
    }

}
