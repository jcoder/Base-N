package base_n;

/**
 * Converter assuming a base with 2 &lt;= index &lt;= 36 and the chars "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
 * @author	jcoder
 */
public class BaseNByIndex extends BaseNConverter
{
    protected static String BASE_ALPHABET = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public BaseNByIndex(int index)  
    {
    	super(BASE_ALPHABET.substring(0, (index >= 2 && index <= BASE_ALPHABET.length()) ? index : 0));
    }

    protected int resolveCharToIndex(char c)
    {
        c = Character.toUpperCase(c);
        return super.resolveCharToIndex(c);
    }

}
