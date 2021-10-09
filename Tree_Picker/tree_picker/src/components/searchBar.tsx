function SearchComponent(props: any): JSX.Element {
    const { handleChange } = props

    return (
        <div>
            <input type='text' id='searchbar' onChange={(e: any) => handleChange(e)} />
        </div>
    )
}

export default SearchComponent;
