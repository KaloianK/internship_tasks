import { Avatar, TableContainer, Table, TableHead, TableBody, TableRow, TableCell, TablePagination, Grid } from "@material-ui/core";
import { GetServerSideProps } from "next";
import { useRouter } from "next/dist/client/router";
import Head from 'next/head'

type reqInfo = {
    count: number,
    page: number
}

type caracterRow = {
    name: string,
    status: string,
    species: string,
    gender: string,
    image: string
};

export type SSRProps = {
    /**
     * Character infos
     */
     characters: {
         info: reqInfo,
         results: Array<caracterRow>
     },
     page: number
};


function SSR({ characters, page }: SSRProps) {
    const { info = { count: 0 }, results = [] } = characters;
    console.log(characters);

    const router = useRouter();

    return (
        <div>
            <Head>
                <title>SSR Characters</title>
                <meta name="description" content="SSR Characters" />
                <link rel="icon" href="/modulus.png" />
            </Head>
            <h1>Server side rendering example - Caracters</h1>
            <TableContainer>
                <Table>
                    <TableHead>
                        <TableCell>Avatar</TableCell>
                        <TableCell>Name</TableCell>
                        <TableCell>Status</TableCell>
                        <TableCell>Species</TableCell>
                        <TableCell>Gender</TableCell>
                    </TableHead>
                    <TableBody>{results.map((row: caracterRow, index: number) => (
                        <TableRow key={index}>
                            <TableCell><Avatar alt={row.name} src={row.image} /> </TableCell>
                            <TableCell>{row.name}</TableCell>
                            <TableCell>{row.status}</TableCell>
                            <TableCell>{row.species}</TableCell>
                            <TableCell>{row.gender}</TableCell>
                        </TableRow>
                    ))}
                    </TableBody>
                </Table>
            </TableContainer>
            <TablePagination
                rowsPerPageOptions={[20]}
                component="div"
                count={info.count}
                rowsPerPage={20}
                page={--page}
                onChangePage={(ev, page) => {
                    console.log(ev, page);
                    
                    router.push(`?page=${++page}`)
                }}
            />
        </div >
    );
}

export const getServerSideProps: GetServerSideProps = async (context: any) => {
    const page = context.query.page || 1;
    const res = await fetch(`https://rickandmortyapi.com/api/character?page=${page}`)
    const characters = await res.json();
    console.log(context);

    return{
        props: {
            characters,
            page
        }
    }
}

export default SSR