package base_n;

/**
 * Converting a value to a different base
 * @author jcoder
 */
public class BaseNConverter {
	protected String alphabetChars = "";
    protected int baseValue = 0;

    /**
     * Creates a new converter, using a given string as alphabet for values, e.g. "01" for binary or "0123456789ABCDEF" for hexadecimal
     * @param alphabet	alphabet
     */
    public BaseNConverter(String alphabet)
    {
        if ((alphabet != null) && (alphabet.length() > 0))
        {
            this.alphabetChars = alphabet;
            this.baseValue = this.alphabetChars.length();
        }
    }

    /**
     * Converts the long value to chars, e.g. "23231" to "5ABF" in Hexadecimal
     * @param l	positive long value
     * @return	char representation in base, empty on error
     */
    public String toChars(long l)
    {
        if (l < 0)
        {
            return "";
        }
        if (this.baseValue < 2)
        {
            return "";
        }
        StringBuilder buffer = new StringBuilder();
        while (l > 0) {
            int index = (int)(l % this.baseValue);
            char c = this.resolveIndexToChar(index);
            buffer.insert(0, c);
            l = (l - index) / this.baseValue;
        }

        if (buffer.length() == 0)
        {
            buffer.append(this.resolveIndexToChar(0));
        }
        return buffer.toString();
    }
    
    /**
     * Converts the string in char representation to long value, e.g. "23B" to "571" in Hexadecmial
     * @param s	string
     * @return	long value, -1 on error
     */
    public long toLong(String s)
    {
        if ((s == null) || (s.length() == 0))
        {
            return -1;
        }
        long sum = 0;
        long multiplier = 1;
        for (int i = s.length() - 1; i >= 0; i--)
        {
            char c = s.charAt(i);
            int index = this.resolveCharToIndex(c);
            if (index < 0)
            {
                return -1;
            }
            sum = sum + multiplier * index;
            if (sum < 0)
            {
                return -1;
            }
            multiplier = multiplier * this.baseValue;
        }
        return sum;
    }
    
    /**
     * Resolves the index to char
     * @param index	index to resolve
     * @return	char
     */
    protected char resolveIndexToChar(int index)
    {
        return this.alphabetChars.charAt(index);
    }
    
    /**
     * Resolves char to index, returning -1 if invalid
     * @param c	char to resolve
     * @return	index position, -1 if invalid
     */
    protected int resolveCharToIndex(char c)
    {
        return this.alphabetChars.indexOf(c);
    }
    
    /**
     * Returns the base value of this converter
     * @return	base of this converter
     */
    public int getBase() {
    	return this.baseValue;
    }
    
    /**
     * Returns the alphabet of this converter
     * @return	alphabet of this converter
     */
    public String getAlphabet() {
    	return this.alphabetChars;
    }
        
}
